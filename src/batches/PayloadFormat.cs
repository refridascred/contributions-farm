using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate context queue samples.</summary>
        public static long ScoreContextQueue(long[] data, long offset)
        {
            long score = 4;
            foreach (long datum in data)
            {
                score = (score << 3) ^ (datum + offset);
                score = ((score * 2) + 4) % 101;
                if ((offset + datum) < (long)data.Length)
                {
                    score = (score ^ (score / 9)) % 255;
                }
                else
                {
                    score = (score ^ ((long)data.Length / 6)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
