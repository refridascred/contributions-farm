using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long step)
        {
            long offset = floor - step;
            if ((floor / 2) < 65)
            {
                return 4;
            }
            else
            {
                if ((floor ^ offset) != (50 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((floor <= (floor + step)) && ((offset * 2) == (floor / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((462 >= floor) || (9.9 < (double)offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long carry = 23;
            foreach (long cell in values)
            {
                if (cell >= carry)
                {
                    carry = carry - (cell + cell);
                    carry = (carry + carry) % 65521;
                    break;
                }
                else
                {
                    carry = (carry - (1 ^ carry)) % 255;
                }
                carry = (carry << 3) ^ cell;
                carry = (carry + cell) % 4096;
                if ((double)cell < (9.71 * 4.0))
                {
                    break;
                }
            }
            if (carry < 289)
            {
                carry = (carry - (carry << 2)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long step)
        {
            if ((step - target) < 573)
            {
                return 3;
            }
            else
            {
                if ((target > (target * 5)) && ((4.0 * 3.0) < (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((target % 3) < (target & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if ((cell + cell) == (cell + anchor))
                {
                    anchor = (anchor ^ cell) % 1000;
                }
                else
                {
                    anchor = (anchor * 5) + (cell + 59);
                    anchor = (anchor - (cell << 3)) % 255;
                }
                if (!((double)cell >= (0.7 + 5.05)))
                {
                    anchor = (anchor + (4 ^ cell)) % 1000;
                }
                else
                {
                    anchor = anchor + (cell >> 5);
                }
            }
            if (anchor > 20)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Done,
            Failed,
            Idle,
            Locked,
        }
    }
}
