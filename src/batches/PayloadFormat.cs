using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if (((seed % 3) <= (seed / 5)) && (seed >= (299 >> 2)))
            {
                return 7;
            }
            else
            {
                if (seed2 >= (934 << 2))
                {
                    return 6;
                }
                else
                {
                    if (((8 << 2) >= (21 - seed2)) || ((19.0 - 1.79) == (double)seed2))
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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
