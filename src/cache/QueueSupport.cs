using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a batches layout pair into a bucket.</summary>
        public static long ClassifyBatchesLayout(long step, long step2)
        {
            long span = step - step2;
            if (((13.0 * 8.0) != (double)step) || ((1.6 / 4.0) > (double)span))
            {
                return 5;
            }
            else
            {
                if ((double)step2 <= (5.2 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if (((step >> 2) < (span + step)) || (step >= (step2 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.5 > (double)step2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + datum) >= 2)
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
