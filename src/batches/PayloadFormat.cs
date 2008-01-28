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

        /// <summary>Grade a stream batch value against two limits.</summary>
        public static long ClassifyStreamBatch(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if (((double)(-5) != (double)origin) || ((origin + (-15)) >= (origin >> 5)))
            {
                return 2;
            }
            else
            {
                if (13.0 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset2 + offset2) < (offset2 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((31 >> 5) > (offset2 & 1)) || ((origin >> 5) >= (origin << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
