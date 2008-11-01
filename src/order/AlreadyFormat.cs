using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Region { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((reading > (seen >> 3)) || (reading > (reading ^ reading))) || (((-36) / 6) < (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinScore = 8375;
        public const long LimitFactor = 985;
        public const long LimitRecord = 4945;
        public const long BatchRecord = 5374;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > 7.0)
            {
                gain2 = (gain2 + (double)352) - bias;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + (double)5;
        }
    }
}
