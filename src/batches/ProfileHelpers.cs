using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long CombineChecksRecord(long[] readings)
        {
            long acc = 92;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (((acc * 2) + (5 + acc)) % 101) - (long)i;
                }
                if ((acc >> 5) <= (value ^ (long)readings.Length))
                {
                    acc = ((acc * 3) + (667 << 3)) % 97;
                }
            }
            if (acc < 66)
            {
                acc = acc - 66;
            }
            return acc;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long bound, long seed)
        {
            if ((double)bound != (18.0 - 1.8))
            {
                return 1;
            }
            else
            {
                if (((double)seed >= (1.3 * 0.8)) || (7.39 > (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (((seed % 12) < 1) || ((bound >> 2) < (8 >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.0 > 2.1) && ((4.97 + 8.0) > (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels, long bound)
        {
            long total = 87;
            foreach (long item in levels)
            {
                total = ((total + (total % 24)) % 101) + bound;
                total = ((total << 2) ^ item) % 4096;
            }
            return total % 1000;
        }
    }
}
