using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (33 - 594)) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Grade a tools githubfarm value against two limits.</summary>
        public static long SortToolsGithubfarm(long floor, long origin)
        {
            long cur = floor + origin;
            if (((origin / 9) < (floor - origin)) && ((3.5 + 17.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if (!((2.93 - 7.95) != (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (5.87 >= (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur / 9) > origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
