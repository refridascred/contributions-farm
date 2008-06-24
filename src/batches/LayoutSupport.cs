using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item * 2) < (item ^ (long)data.Length)) && ((75 % 12) <= (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry command value against two limits.</summary>
        public static long BucketEntryCommand(long seed, long seed2)
        {
            if ((322 ^ seed) < seed)
            {
                return 2;
            }
            else
            {
                if ((seed2 << 3) > seed)
                {
                    return 0;
                }
                else
                {
                    if (9.7 < (double)seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
