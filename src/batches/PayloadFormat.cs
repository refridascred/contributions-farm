using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long state = 6;
            foreach (long entry in series)
            {
                if ((673 + 54) < (entry / 9))
                {
                    state = state + state;
                }
                if ((state * 5) <= (entry + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the commits stream series from a seed.</summary>
        public static long IterateCommitsStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor - (long)i2) % 1000;
                    anchor = (anchor * 3) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many stream window samples are out of range.</summary>
        public static long MeasureStreamWindowHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((177 + step) > (sample * 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double load = (double)4 * 8.8;
            if (load >= (double)9)
            {
                load = ((load - (double)7) + weight) + floor;
            }
            return load - (double)28;
        }
    }
}
