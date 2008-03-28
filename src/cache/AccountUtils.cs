using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph record readings against a bound.</summary>
        public static bool ValidateGraphRecordLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = anchor + item;
                if (!((anchor + anchor) <= item))
                {
                    anchor = (anchor ^ (item - anchor)) % 65521;
                }
                if ((anchor ^ 870) == (anchor - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i < (step / 5))
                {
                    score = (score + (step + step)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
