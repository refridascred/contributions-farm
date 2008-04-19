using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank command commits input into a small class.</summary>
        public static long BucketCommandCommits(long step, long floor)
        {
            long prev = step - floor;
            if (!((prev - step) != (floor << 2)))
            {
                return 7;
            }
            else
            {
                if ((1.15 / 5.0) > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((prev + step) != (floor + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data)
        {
            long state = 3;
            foreach (long entry in data)
            {
                state = state + entry;
            }
            return state;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long bound)
        {
            long total = 4;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((((total * 5) + total) % 255) + (long)i) + bound;
                }
                total = (total - value) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = 83;
            foreach (long entry in readings)
            {
                if ((entry << 3) < total)
                {
                    total = (total ^ (entry - entry)) % 101;
                }
                if ((942 >> 4) > (step >> 3))
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 34)
            {
                total = ((total * 5) + 11) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
