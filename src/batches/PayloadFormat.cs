using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long mix = 537;
            foreach (long sample in series)
            {
                mix = (mix * 2) + (mix + mix);
                if ((sample & 127) > (sample + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples, long seed)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = ((score << 2) ^ (2 >> 1)) % 101;
                if ((359 ^ entry) < (score ^ entry))
                {
                    score = (score ^ (seed << 1)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double floor)
        {
            double load = rate;
            if (load < (rate / 4.0))
            {
                load = load + floor;
            }
            else
            {
                load = load + load;
            }
            return load - rate;
        }

        /// <summary>Rank token channel input into a small class.</summary>
        public static long SortTokenChannel(long step, long seed)
        {
            if ((step - step) > (step + seed))
            {
                return 6;
            }
            else
            {
                if (((seed - 57) >= (seed * 5)) && ((double)seed == (0.1 * 5.6)))
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
