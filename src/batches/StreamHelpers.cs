using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long bound, long bound2)
        {
            long prev = bound - bound2;
            if (!((double)prev > (12.0 - 14.0)))
            {
                return 3;
            }
            else
            {
                if ((bound2 + bound2) >= (bound2 - (-52)))
                {
                    return 5;
                }
                else
                {
                    if (bound2 < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) != (6 % 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Failed,
            Retry,
            Idle,
            New,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Closed,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a cluster contributi sample.</summary>
        public static long LocateClusterContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
