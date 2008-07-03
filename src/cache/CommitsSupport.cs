using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long seed)
        {
            long prev = target - seed;
            if ((((-71) % 60) != (prev / 6)) && ((target & 3) >= 85))
            {
                return 6;
            }
            else
            {
                if ((target + target) > (prev + seed))
                {
                    return 4;
                }
                else
                {
                    if (((prev / 3) == (target + 20)) && ((target - target) < (prev + prev)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] series, long step)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                long seen = (step * 2) + (reading << 3);
                if ((double)seen < (14.0 * 0.6))
                {
                    break;
                }
                mark = (mark - (reading ^ 48)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the report record series from a seed.</summary>
        public static long SeriesReportRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - 37) % 101;
                if ((88 + acc) == (acc / 3))
                {
                    acc = (acc ^ (acc + 54)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (step & 1)) % 1000;
                }
                acc = (acc + (8 - (long)i)) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Locked,
            Ready,
            Failed,
            Draft,
        }
    }
}
