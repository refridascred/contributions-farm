using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer tools entry stays within the limit.</summary>
        public static bool CheckBufferToolsBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Done,
            Failed,
        }
    }
}
