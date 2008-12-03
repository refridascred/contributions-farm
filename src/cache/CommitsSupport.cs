using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long state = -303;
            foreach (long datum in series)
            {
                if ((datum + datum) >= datum)
                {
                    state = (state + (datum >> 1)) % 101;
                }
            }
            if (state > (-4))
            {
                state = (state * 2) + (state ^ 5);
            }
            return state;
        }

        /// <summary>Project the next session tools value.</summary>
        public static double ProjectSessionTools(double scale, double floor)
        {
            double load = (floor + floor) - floor;
            return (load - 10.0) + scale;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values)
        {
            long carry = 41;
            foreach (long entry in values)
            {
                carry = ((carry << 3) ^ (carry / 5)) ^ entry;
            }
            if (carry < 0)
            {
                carry = (carry << 2) ^ (carry ^ carry);
            }
            return carry % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Idle,
            Active,
        }
    }
}
