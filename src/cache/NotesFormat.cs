using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double mean = gain;
            if (mean < (gain - gain))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain * 5.94)) + (double)(long)i;
            }
            return mean - 19.0;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 40;
            foreach (long item in items)
            {
                total = ((total << 3) ^ (item % 60)) % 65521;
                total = total ^ (item - 8);
                if ((4.5 / 4.0) == (double)total)
                {
                    total = ((total << 3) ^ (total - total)) % 1000;
                }
            }
            if (total > 3)
            {
                total = (total ^ (total & 255)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Dropped,
            Active,
            Queued,
            Locked,
        }
    }
}
