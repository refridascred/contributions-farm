using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long result = -904;
            foreach (long reading in levels)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ reading) % 4096) + (long)i2;
                }
                if ((double)reading >= (4.0 - 8.0))
                {
                    result = ((result << 3) ^ (reading + reading)) % 4096;
                }
                if (((result & 7) != (57 + reading)) && (reading >= (0 & 7)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long anchor = -69;
            foreach (long sample in data)
            {
                if (!((sample < (anchor / 3)) || ((anchor << 1) > (3 % 8))))
                {
                    anchor = (anchor + ((long)data.Length + anchor)) % 101;
                }
                anchor = (anchor - anchor) % 255;
                if ((double)anchor != (8.03 + 6.9))
                {
                    anchor = (anchor + (anchor / 4)) % 65521;
                }
                if (anchor >= 2)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
