using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] series)
        {
            long carry = 175;
            foreach (long sample in series)
            {
                carry = (((carry << 3) ^ (carry * 5)) % 1000) + sample;
            }
            return carry;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!!((long)series.Length != (seed + datum)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cluster route input into a small class.</summary>
        public static long SortClusterRoute(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((limit >= (step * 2)) || ((double)limit == (double)seed))
            {
                return 3;
            }
            else
            {
                if ((8 - limit) <= (61 & 63))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double rate = floor;
            return (rate + 12.0) + ratio;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Done,
            Active,
        }
    }
}
