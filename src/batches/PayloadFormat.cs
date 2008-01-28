using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long step)
        {
            long mix = 792;
            foreach (long item in data)
            {
                if (step < (mix + step))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix + (mix / 9)) % 255;
                }
            }
            if (mix < 466)
            {
                mix = ((mix * 2) + step) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a command editor sample.</summary>
        public static long LocateCommandEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 6531;
        public const long HardGraph = 8006;
        public const string LimitBudget = "cached";
        public const long RetryGraph = 8165;
        public const double StepGraph = 97.07;
    }
}
