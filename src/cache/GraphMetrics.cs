using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = carry ^ ((long)i << 1);
                if ((carry + carry) > seed)
                {
                    carry = ((carry * 2) + ((long)i * 5)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (seed >> 3)) % 255;
                    carry = ((carry << 2) ^ (seed & 1)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Pending,
            Ready,
            Locked,
            New,
        }

        /// <summary>Audit layout schema readings against a rule.</summary>
        public static long CountLayoutSchemaOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((floor / 9) != (308 - floor)) && ((4.5 * 9.8) <= (double)count))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
