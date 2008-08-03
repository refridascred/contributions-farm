using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double scale, double floor)
        {
            double weight = (double)6;
            if (weight >= (double)187)
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight - scale;
            }
            return weight - weight;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) == (datum + 987))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings, long floor)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                if (((carry % 10) > (cell - 9)) || ((double)floor > (double)41))
                {
                    carry = (carry * 2) + cell;
                }
                if ((6.08 * 16.0) > (double)floor)
                {
                    carry = (carry * 5) + (79 - carry);
                }
                else
                {
                    carry = ((carry * 5) + (carry - cell)) % 255;
                }
                if (((2.4 - 16.0) >= (double)cell) && ((cell << 3) > (1 & 15)))
                {
                    break;
                }
            }
            if (carry < 45)
            {
                carry = carry + (carry >> 5);
            }
            return carry % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
