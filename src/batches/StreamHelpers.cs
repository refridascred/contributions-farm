using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many already schema samples are out of range.</summary>
        public static long TallyAlreadySchemaHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((floor & 31) > (datum & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long floor)
        {
            long acc = 210;
            foreach (long entry in data)
            {
                if ((double)entry <= (double)15)
                {
                    acc = (acc - 906) + floor;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 5) + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Project the next command schema value.</summary>
        public static double SmoothCommandSchema(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > weight)
            {
                bias2 = bias2 + 9.0;
            }
            return bias2 - (bias2 + weight);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload graph series from a seed.</summary>
        public static long DerivePayloadGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                long prev = (48 * 4) << 1;
                if (((prev % 64) == (prev << 3)) || (((long)i - prev) <= ((long)i + (-255))))
                {
                    long cur = (bound << 1) - (prev - prev);
                    prev = (prev - (prev - cur)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
