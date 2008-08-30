using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command record entries.</summary>
        public static long TallyCommandRecord(long[] readings)
        {
            long acc = 98;
            foreach (long sample in readings)
            {
                acc = ((acc << 3) ^ acc) % 101;
                if ((acc % 97) > sample)
                {
                    acc = ((acc * 5) + (sample / 7)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Match up batches tools samples.</summary>
        public static long PairBatchesToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up layout stream samples.</summary>
        public static long PairLayoutStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
