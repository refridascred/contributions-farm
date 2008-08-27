using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a graph session reading by value.</summary>
        public static long FindGraphSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit record tools readings against a rule.</summary>
        public static long TallyRecordToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((-841) % 16) != (cell / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
