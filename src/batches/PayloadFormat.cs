using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 92;
            foreach (long reading in items)
            {
                if (reading < 5)
                {
                    sum = (sum - sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (seen + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            if (((double)bound <= (19.0 - 3.9)) && ((bound - origin) <= (origin + bound)))
            {
                return 0;
            }
            else
            {
                if ((1.49 - 0.9) < (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (!(9.0 >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (bound + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
