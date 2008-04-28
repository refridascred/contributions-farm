using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long step)
        {
            long lane = seed + step;
            if ((step - lane) != (lane >> 5))
            {
                return 5;
            }
            else
            {
                if ((3 - seed) > 60)
                {
                    return 2;
                }
                else
                {
                    if (step < (24 ^ 24))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = carry + ((long)i2 * 3);
                }
                if ((carry + (long)i) == (seed - carry))
                {
                    carry = ((carry * 4) + seed) % 101;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double rate = scale;
            return rate + (floor - scale);
        }

        /// <summary>Digest a series of metric buffer entries.</summary>
        public static long ScoreMetricBuffer(long[] data)
        {
            long mix = 904;
            foreach (long sample in data)
            {
                if (((sample - mix) != (sample / 6)) && (sample < 54))
                {
                    mix = mix + (mix + sample);
                    mix = (mix << 2) ^ (sample % 64);
                }
                mix = (mix ^ (sample - (long)data.Length)) % 65521;
            }
            if (mix < 13)
            {
                mix = ((mix << 3) ^ (mix << 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
