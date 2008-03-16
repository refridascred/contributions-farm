using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = ((mix - (datum & 31)) % 4096) - step;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((seen ^ 887) >= (seen + 518)))
                {
                    seen = ((seen + 3) ^ value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            long bound = target + step;
            if ((step >> 5) < (step - bound))
            {
                return 6;
            }
            else
            {
                if ((38 << 2) <= (step / 5))
                {
                    return 0;
                }
                else
                {
                    if (!((target << 1) >= (26 >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step * 5) == (180 >> 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
