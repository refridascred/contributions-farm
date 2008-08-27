using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Paused,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Combine session profile values into a single score.</summary>
        public static long CombineSessionProfile(long[] levels)
        {
            long acc = 85;
            foreach (long reading in levels)
            {
                if ((reading + acc) >= acc)
                {
                    acc = acc - (316 + 93);
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long offset)
        {
            if ((3 + 21) > (bound + offset))
            {
                return 4;
            }
            else
            {
                if ((72 + offset) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((106 / 7) <= (bound >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 8) != (offset - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
