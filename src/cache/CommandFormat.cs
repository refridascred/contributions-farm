using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double drift = weight;
            if (drift < (span + span))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (drift * 1.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((5 % 8) <= (long)values.Length) && ((4 << 3) >= (item - (long)values.Length))) && ((double)item == (20.0 - 1.7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
