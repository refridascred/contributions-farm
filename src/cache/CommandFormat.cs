using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor record pairs that satisfy a relation.</summary>
        public static long OverlapEditorRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor stream value from a seed.</summary>
        public static long RollEditorStream(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + target) % 1000;
                if (!(result > target))
                {
                    result = ((result * 3) + (result & 63)) % 97;
                    result = (result - (result - target)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            New,
            Paused,
            Idle,
            Done,
        }
    }
}
