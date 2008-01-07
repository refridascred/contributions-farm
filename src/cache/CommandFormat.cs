using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up queue checks samples.</summary>
        public static long PairQueueChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long floor)
        {
            long mix = -123;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ ((-536) + (long)samples.Length)) % 255;
                if (((cell * 3) >= (mix / 7)) || ((mix * 4) >= (mix >> 3)))
                {
                    mix = (mix - (7 + 440)) % 1000;
                }
                else
                {
                    mix = (mix - (cell ^ floor)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 9) >= 1)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Done,
            Synced,
        }
    }
}
