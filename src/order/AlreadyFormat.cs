using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long origin)
        {
            long anchor = 91;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor * 2) + (long)i) % 255) + origin;
                }
                if ((0.57 / 2.0) >= (double)sample)
                {
                    anchor = anchor ^ (long)series.Length;
                }
            }
            if (anchor > (-278))
            {
                anchor = (anchor << 2) ^ 30;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many contributi editor samples are out of range.</summary>
        public static long MeasureContributiEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value / 8) > (value & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double drift = (double)(86 - 607);
            if (drift <= (double)773)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)13;
            }
            return drift + rate;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target == (5.41 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((span - span) <= (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 / 2.0) == (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
