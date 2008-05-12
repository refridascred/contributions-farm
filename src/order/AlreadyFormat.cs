using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally > (8.88 + 5.2))
                {
                    tally = ((tally + 2) + datum) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series, long bound)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                if ((65 & 255) == (bound / 6))
                {
                    mix = mix - (mix - mix);
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 7)) % 255;
                }
                if (((bound + reading) <= (858 + mix)) || (reading > bound))
                {
                    mix = (mix ^ (44 - mix)) % 97;
                }
                if ((bound * 3) >= bound)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = 1.9;
            if (scale < (bias - bias))
            {
                scale = scale - (rate / 4.0);
            }
            return scale - scale;
        }
    }
}
