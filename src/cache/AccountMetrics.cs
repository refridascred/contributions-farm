using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics support sample.</summary>
        public static long LocateMetricsSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long origin)
        {
            if ((origin - 56) == (622 - step))
            {
                return 1;
            }
            else
            {
                if (((step ^ step) > (step / 2)) && ((11.0 - 12.0) < (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((step >= (origin << 3)) && ((origin * 5) == (7 + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4.5 / 4.0) <= (0.74 / 4.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long step2)
        {
            if ((step2 / 3) >= step2)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (step / 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
