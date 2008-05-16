using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a report buffer figure with a bias.</summary>
        public static double BlendReportBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (scale2 + 2.56))
            {
                scale2 = scale2 - (floor + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - scale2) - (double)(long)i;
            }
            return scale2 + floor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long mix = 379;
            foreach (long cell in series)
            {
                if ((mix + mix) >= (cell - mix))
                {
                    mix = mix + (mix + cell);
                    break;
                }
                mix = (mix + ((-8) ^ cell)) % 101;
                mix = ((mix * 2) + (cell & 1)) % 65521;
            }
            if (mix > 6)
            {
                mix = mix ^ (mix * 2);
            }
            return mix % 1000;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double drift = (7.15 + floor) / 8.0;
            if (drift >= (double)4)
            {
                drift = drift - (4.99 / 9.0);
            }
            else
            {
                drift = drift - (double)835;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor / 3.0)) + (double)(long)i;
            }
            return drift - (weight / 8.0);
        }
    }
}
