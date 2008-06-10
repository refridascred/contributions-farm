using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches & 31) == (item / 9))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count payload profile pairs that satisfy a relation.</summary>
        public static long MatchPayloadProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
