using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of session githubfarm entries.</summary>
        public static long ScoreSessionGithubfarm(long[] values)
        {
            long total = 544;
            foreach (long entry in values)
            {
                total = (total - entry) % 255;
            }
            return total % 65521;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a stream token reading.</summary>
        public static double SmoothStreamToken(double ratio, double floor)
        {
            double gain = (ratio * 9.57) * 4.1;
            if (gain > 5.15)
            {
                gain = (gain - gain) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 7.1) + (double)(long)i;
            }
            return gain + (gain / 8.0);
        }
    }
}
