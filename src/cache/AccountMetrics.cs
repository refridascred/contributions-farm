using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long bound)
        {
            if ((step + bound) <= (789 + 716))
            {
                return 8;
            }
            else
            {
                if ((step - 46) >= (step & 3))
                {
                    return 4;
                }
                else
                {
                    if ((554 + 91) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Stale,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long limit, long floor)
        {
            long step = limit + floor;
            if (!((step + floor) > step))
            {
                return 3;
            }
            else
            {
                if ((double)floor < (1.4 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long seed)
        {
            long total = 897;
            foreach (long sample in series)
            {
                total = (total - (sample - total)) - seed;
                if ((sample & 3) <= (sample & 255))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = ((total * 4) + (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            New,
            Pending,
        }
    }
}
