using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long floor, long target)
        {
            long lane = floor + target;
            if ((floor - floor) > (4 - lane))
            {
                return 0;
            }
            else
            {
                if ((target << 2) < 2)
                {
                    return 2;
                }
                else
                {
                    if (!((target - floor) >= (floor & 255)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor - target))
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

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels)
        {
            long score = 443;
            foreach (long reading in levels)
            {
                long prev = (score * 4) + score;
                if (((reading << 1) == (8 >> 4)) && (832 < (prev + 70)))
                {
                    score = ((score << 2) ^ (698 * 5)) % 255;
                }
                if ((score < (reading << 1)) || ((long)levels.Length != (reading + reading)))
                {
                    score = ((score << 3) ^ (score & 31)) % 255;
                }
                if ((reading + score) >= (reading - score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long limit)
        {
            long edge = bound - limit;
            if ((8 ^ edge) < (bound + bound))
            {
                return 6;
            }
            else
            {
                if (((604 ^ limit) > (20 + bound)) || (edge <= (bound / 7)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Combine already layout values into a single score.</summary>
        public static long DigestAlreadyLayout(long[] values, long offset)
        {
            long total = 0;
            foreach (long reading in values)
            {
                total = total ^ (total - reading);
                if ((offset + reading) != (total % 60))
                {
                    total = total ^ (4 & 3);
                }
                total = ((total * 2) + reading) % 97;
            }
            return total % 1000;
        }
    }
}
