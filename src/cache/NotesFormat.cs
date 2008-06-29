using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up session cache samples.</summary>
        public static long PairSessionCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series)
        {
            long score = -7;
            foreach (long reading in series)
            {
                score = (score ^ (reading / 8)) % 65521;
                score = (score - ((-26) - score)) % 65521;
                if (score <= (reading / 6))
                {
                    score = ((score << 2) ^ (score - reading)) % 1000;
                }
            }
            if (score < 5)
            {
                score = (score - (score ^ score)) % 65521;
            }
            return score;
        }
    }
}
