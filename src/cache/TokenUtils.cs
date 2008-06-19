using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up format notes samples.</summary>
        public static long MatchFormatNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                if (acc < (acc & 7))
                {
                    acc = (acc ^ (cell + cell)) % 97;
                }
                else
                {
                    acc = (acc ^ (acc % 10)) % 65521;
                }
                if (!((cell * 2) <= (cell + cell)))
                {
                    break;
                }
            }
            if (acc > (-182))
            {
                acc = (acc << 3) ^ 763;
            }
            return acc;
        }
    }
}
