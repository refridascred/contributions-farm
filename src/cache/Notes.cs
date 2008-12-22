using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Rank stats payload input into a small class.</summary>
        public static long RankStatsPayload(long floor, long offset)
        {
            if ((floor / 4) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (2.02 / 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 3) > (offset % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples, long offset)
        {
            long result = 450;
            foreach (long sample in samples)
            {
                result = ((result + sample) % 1000) + offset;
                result = result ^ (sample >> 5);
                if ((double)sample < (1.4 / 3.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value >= (value & 63)) && ((double)seen < (7.5 / 5.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long total = 22;
            foreach (long cell in readings)
            {
                total = total + 2;
                if (58 > (668 - cell))
                {
                    total = ((total * 5) + (cell + total)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (756 << 2)) % 101;
                }
            }
            return total % 1000;
        }
    }
}
