using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 3899;
        public const long WindowEntry = 4031;
        public const string StepEntry = "primary-1";
        public const long MinInterval = 7897;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings)
        {
            long mix = -8;
            foreach (long sample in readings)
            {
                if ((sample + (-536)) <= 96)
                {
                    mix = (mix + sample) % 97;
                }
                if (((sample + mix) <= mix) || (sample >= ((long)readings.Length & 15)))
                {
                    mix = ((mix * 3) + (-4)) % 65521;
                }
            }
            return mix;
        }
    }
}
