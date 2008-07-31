using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (gain / 2.0))
            {
                gain = (gain + (gain / 7.0)) + ratio;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (4.59 * 9.88)) + (double)(long)i;
            }
            return gain + bias;
        }
    }
}
