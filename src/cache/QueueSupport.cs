using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((offset - (long)values.Length) > (entry + 34)) && ((double)offset > (double)36)) || (entry > ((-45) << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((offset + floor) >= (next >> 4))
            {
                return 3;
            }
            else
            {
                if ((offset % 100) <= (-550))
                {
                    return 8;
                }
                else
                {
                    if ((5 + floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((229 + next) == (next % 24))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4261;
        public const double HardFormat = 80.36;
        public const double BatchSpan = 34.29;
        public const long MaxFormat = 998;
    }
}
