using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long limit)
        {
            if ((target <= (249 & 255)) && ((double)target != (1.0 + 7.8)))
            {
                return 1;
            }
            else
            {
                if ((target << 3) != (35 - 3))
                {
                    return 5;
                }
                else
                {
                    if (((limit << 3) >= (target + target)) && ((target % 60) > limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
