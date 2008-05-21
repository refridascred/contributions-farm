using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples, long bound)
        {
            long score = -461;
            foreach (long sample in samples)
            {
                score = (score - (831 & 127)) ^ sample;
            }
            if (score > 950)
            {
                score = ((score * 3) + (bound + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a notes checks sample.</summary>
        public static long SeekNotesChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first support channel entry that matches the target.</summary>
        public static long SeekSupportChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit > (long)i) || ((limit ^ mark) < (limit & 127)))
                {
                    mark = mark + (mark % 5);
                }
                mark = (mark ^ (mark << 1)) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double bias = (double)(572 - (-79));
            if (bias < (3.53 / 8.0))
            {
                bias = bias + span;
            }
            return bias - rate;
        }
    }
}
