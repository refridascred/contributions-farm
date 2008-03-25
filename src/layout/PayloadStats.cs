using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Accumulate context token samples.</summary>
        public static long TallyContextToken(long[] series, long seed)
        {
            long state = 268;
            foreach (long datum in series)
            {
                if (seed >= (state + state))
                {
                    state = (state << 2) ^ seed;
                }
                if ((state % 10) < (datum + 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of commits graph entries.</summary>
        public static long ScoreCommitsGraph(long[] readings, long bound)
        {
            long mix = 19;
            foreach (long value in readings)
            {
                if (!(value < (value + bound)))
                {
                    mix = mix - mix;
                    mix = (mix - (bound - 4)) % 65521;
                }
                mix = (mix << 2) ^ (value << 3);
            }
            return mix;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Synced,
        }
    }
}
