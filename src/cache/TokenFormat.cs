using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double rate = (double)((-385) / 4);
            if (rate >= (floor - scale))
            {
                rate = rate + (double)6;
            }
            else
            {
                rate = rate + 2.0;
            }
            return rate + floor;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
