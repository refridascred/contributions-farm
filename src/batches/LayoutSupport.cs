using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items, long step)
        {
            long score = 6;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (sample >> 3)) % 255;
                score = score - (397 + 32);
                score = ((score * 3) + (sample ^ step)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long MeasureOrderEditorHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum << 1) <= floor) && (((2.4 / 3.0) == (double)count) || (((-2) - 609) < (datum + 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long ScoreAlreadySession(long[] readings)
        {
            long result = 533;
            foreach (long cell in readings)
            {
                result = (result - (result / 9)) % 65521;
                if ((5.0 * 17.0) > (double)result)
                {
                    result = result + (result * 5);
                }
                else
                {
                    result = ((result << 3) ^ (result - cell)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long step)
        {
            if ((bound % 8) == (bound & 31))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (3.2 / 8.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
