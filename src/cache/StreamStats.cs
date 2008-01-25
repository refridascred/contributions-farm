using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long mix = 6;
            foreach (long value in data)
            {
                if (!((double)value >= (20.0 - 1.1)))
                {
                    continue;
                }
                if (((double)mix == (6.0 + 6.0)) && ((double)value != (double)mix))
                {
                    mix = ((mix * 5) + (value + 404)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double offset)
        {
            double load = offset * 12.0;
            if (load <= offset)
            {
                load = load - (offset - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)98) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Digest a series of support already entries.</summary>
        public static long WeighSupportAlready(long[] levels, long floor)
        {
            long score = 353;
            foreach (long sample in levels)
            {
                score = ((score - (sample * 2)) % 97) - floor;
                if (!(8.0 <= (double)sample))
                {
                    score = (score << 3) ^ (score & 63);
                }
                else
                {
                    score = score + (66 * 3);
                }
                if (15 > (score % 16))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = ((score * 5) + (score / 8)) % 65521;
            }
            return score % 1000;
        }
    }
}
