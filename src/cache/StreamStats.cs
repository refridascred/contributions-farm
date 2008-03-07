using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = total + (step + step);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long MeasureBufferRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches ^ matches) < (reading + reading)) && !(matches < 765))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
