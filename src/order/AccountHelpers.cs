using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a report session figure with a bias.</summary>
        public static double AdjustReportSession(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain + ratio;
            }
            return gain - span;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double gain = (rate / 4.0) + 1.68;
            if (gain > 17.0)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)34;
            }
            return gain + (floor + gain);
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long offset)
        {
            long score = 808;
            foreach (long cell in data)
            {
                score = (((score << 3) ^ (offset - offset)) % 1000) ^ cell;
                if ((4.44 / 2.0) >= (double)offset)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm githubfarm samples are out of range.</summary>
        public static long MeasureFarmGithubfarmGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((seen << 3) != (step + step)) || ((step + seen) <= (seen >> 5))) || (((12.0 * 1.1) >= (double)sample) || (11 > (step + sample))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
