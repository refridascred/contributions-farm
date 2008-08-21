using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 282;
            foreach (long item in items)
            {
                if ((item <= (item + score)) && ((score << 3) >= (item / 4)))
                {
                    score = (score + (item + 0)) % 255;
                }
                else
                {
                    score = score ^ (item + score);
                }
                if ((13.0 * 2.9) > (double)item)
                {
                    break;
                }
            }
            if (score < 31)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell * 3) < (count + (-603))))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
