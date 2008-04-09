using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(((93 & 63) == (hits >> 3)) && (datum <= (hits >> 5))))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((limit - 762) != (limit << 3))
            {
                return 5;
            }
            else
            {
                if ((limit2 - gap) <= (30 - limit))
                {
                    return 6;
                }
                else
                {
                    if ((1 + gap) == (limit2 & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit2 ^ gap) > (limit2 >> 5))
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
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i < (origin % 24)))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long FoldAlreadyFarm(long[] samples)
        {
            long anchor = -8;
            foreach (long item in samples)
            {
                anchor = ((anchor * 5) + (anchor * 3)) + item;
                if (!((anchor / 7) <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
