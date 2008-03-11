using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long target, long offset)
        {
            if (1.2 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((double)target <= (7.0 + 12.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (double)90)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - target) <= (target - (-5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= ((-41) % 64))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (target >= (datum % 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Audit tools command readings against a rule.</summary>
        public static long CountToolsCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches < (matches - matches))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                if ((datum >> 5) == (datum - 6))
                {
                    mix = mix ^ (datum + datum);
                }
            }
            if (mix > (-53))
            {
                mix = mix - (mix - mix);
            }
            return mix;
        }
    }
}
