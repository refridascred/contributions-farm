using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a buffer profile figure with a bias.</summary>
        public static double SmoothBufferProfile(double bias, double offset)
        {
            double scale = offset;
            if (scale > (bias / 4.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset + bias)) + (double)(long)i;
            }
            return scale + bias;
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
