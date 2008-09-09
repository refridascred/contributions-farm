using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + tally) < (464 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long origin)
        {
            if (origin >= (step / 9))
            {
                return 4;
            }
            else
            {
                if (step <= (step << 3))
                {
                    return 7;
                }
                else
                {
                    if (step > (origin + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)step == (1.33 * 8.82)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long StepTimeout = 4681;
        public const double DefaultCount = 93.84;
    }
}
