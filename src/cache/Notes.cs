using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            New,
            Ready,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((reading >> 4) >= ((long)samples.Length / 5)) || (20.0 >= (double)reading)))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((3.0 + 10.0) <= (double)seed)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items)
        {
            long acc = 433;
            foreach (long cell in items)
            {
                acc = (acc ^ ((-2) + cell)) % 101;
                if (((cell ^ cell) < (acc - cell)) || ((acc / 3) >= (cell - cell)))
                {
                    acc = ((acc * 3) + (acc ^ 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Find the first payload githubfarm entry that matches the target.</summary>
        public static long LocatePayloadGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
