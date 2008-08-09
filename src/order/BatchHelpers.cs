using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up window token samples.</summary>
        public static long MatchWindowTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum >= (5.8 / 7.0)) || ((datum << 3) > (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches <= (step / 5))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
