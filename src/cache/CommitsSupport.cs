using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Pending,
            New,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long target)
        {
            if ((target >> 5) < (target << 3))
            {
                return 3;
            }
            else
            {
                if ((target + target) == (step << 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (bound > ((-3) - bound))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
