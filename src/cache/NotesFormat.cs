using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report contributi samples.</summary>
        public static long PairReportContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix - (long)i) % 4096) - (long)i2;
                }
                if ((double)mix <= (4.0 + 15.0))
                {
                    break;
                }
                mix = ((mix * 4) + (mix << 1)) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
